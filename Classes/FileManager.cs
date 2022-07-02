using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Text;

namespace CinemaBookingSystem.Classes
{
    class FileManager
    {
        // Define binary writer.
        private BinaryFormatter _writer = new BinaryFormatter();

        // Define binary reader.
        private BinaryFormatter _reader = new BinaryFormatter();

        // Save Method - stores data (binary) to specified file name.
        public void Save(DoubleLinkedList data, string path)
        {
            // Create write stream.
            Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

            // Serialise seat DLL.
            _writer.Serialize(stream, data);

            // Close file, release memory.
            stream.Close();
        }

        // Load Method - load data (binary) and returns it.
        public DoubleLinkedList Load(string path)
        {

            // Create read stream.
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

            // Deserialise seat DLL bin data.
            DoubleLinkedList data = (DoubleLinkedList)_reader.Deserialize(stream);

            // Close file, release memory.
            stream.Close();

            return data;
        }
    }
}
