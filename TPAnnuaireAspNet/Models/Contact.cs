using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using TPAnnuaireAspNet.Tools;

namespace TPAnnuaireAspNet.Models
{
    public class Contact
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phone;
        private static int counter = 0;
        private static List<Contact> liste = new();
        private static string request;
        private static SqlConnection connection;
        private static SqlCommand command;
        private static SqlDataReader reader;

        public Contact()
        {
        }

        public Contact(string firstName, string lastName, string phone) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public Contact(int id, string firstName, string lastName, string phone) : this()
        {
            this.Id = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public static int Counter { get => counter; }
        public static List<Contact> Liste { get => liste; set => liste = value; }

        public bool Save()
        {
            request = "INSERT INTO utilisateur (LastName, FirstName, Phone) OUTPUT INSERTED.ID values (@nom, @prenom, @telephone)";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@nom", LastName));
            command.Parameters.Add(new SqlParameter("@prenom", FirstName));
            command.Parameters.Add(new SqlParameter("@telephone", Phone));
            connection.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return Id > 0;
        }

        public static List<Contact> GetContacts()
        {
            //Logique pour chercher liste des contacts
            List<Contact> contacts = new List<Contact>();
            request = "SELECT id, LastName, FirstName, Phone from utilisateur";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Contact contact = new Contact(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                contacts.Add(contact);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return contacts;
        }

        public static List<Contact> GetContactById(int id)
        {
            //Logique pour chercher liste des contacts
            List<Contact> contacts = new List<Contact>();
            request = "SELECT LastName, FirstName, Phone from utilisateur where id = @id";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", id));
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Contact contact = new Contact(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                contacts.Add(contact);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return contacts;
        }

        public bool UpdateContact(int id)
        {
            request = "UPDATE utilisateur SET LastName=@nom, FirstName=@prenom, Phone=@telephone WHERE id = @id";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@nom", LastName));
            command.Parameters.Add(new SqlParameter("@prenom", FirstName));
            command.Parameters.Add(new SqlParameter("@telephone", Phone));
            command.Parameters.Add(new SqlParameter("@id", id));
            connection.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return Id > 0;
        }

        public static List<Contact> DeleteContact(int id)
        {
            List<Contact> listeContact = new List<Contact>();
            listeContact = GetContactById(id);
            request = "DELETE FROM utilisateur WHERE id=@id";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", id));
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(0) == id)
                {
                    listeContact.RemoveAt(id);
                }
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return listeContact;
        }
    }
}


