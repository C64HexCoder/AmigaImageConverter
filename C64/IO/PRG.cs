using System;
using System.IO;
using System.Linq;

namespace C64.IO
{
    public class PRG
    {
        public static void LoadPRGFile(string filePath)
        {
            byte[] prgData = File.ReadAllBytes(filePath);
            if (prgData.Length < 2)
            {
                Console.WriteLine("Invalid PRG file.");
                return;
            }

            // The first two bytes of a PRG file indicate the load address
            ushort loadAddress = (ushort)(prgData[0] | (prgData[1] << 8));
            byte[] programData = prgData.Skip(2).ToArray();

            // Here you would typically load the program data into the C64's memory
            // at the specified load address. This is just a placeholder for demonstration.
            Console.WriteLine($"Loaded PRG file with load address: {loadAddress:X4} and data length: {programData.Length}");
        }


    public bool SavePRGFile(string filePath, ushort loadAddress, byte[] programData)

        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    // Write the load address as the first two bytes
                    fs.WriteByte((byte)(loadAddress & 0xFF)); // Low byte
                    fs.WriteByte((byte)((loadAddress >> 8) & 0xFF)); // High byte
                    // Write the program data
                    fs.Write(programData, 0, programData.Length);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving PRG file: {ex.Message}");
                return false;
            }
        }
    }
}
