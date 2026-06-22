using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace C64.IO
{
    public static class SpriteIoManager
    {
        // ==========================================
        // 1. פורמט גולמי / בינארי (Raw Binary)
        // ==========================================
        public static void SaveAsBinary(string filePath, byte[] spriteData)
        {
            File.WriteAllBytes(filePath, spriteData);
        }

        public static byte[] LoadFromBinary(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }

        // ==========================================
        // 2. פורמט קומודור סטנדרטי (PRG)
        // כולל 2 בתים ראשונים של כתובת טעינה בזיכרון
        // ==========================================
        public static void SaveAsPrg(string filePath, byte[] spriteData, ushort loadAddress)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                // כתיבת כתובת הטעינה (למשל $0c00) - קודם הבית הנמוך ואז הגבוה (Little Endian)
                writer.Write((byte)(loadAddress & 0xFF));
                writer.Write((byte)((loadAddress >> 8) & 0xFF));

                // כתיבת נתוני הספרייט
                writer.Write(spriteData);
            }
        }

        public static byte[] LoadFromPrg(string filePath, out ushort loadAddress)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                // קריאת 2 הבתים הראשונים שמייצגים את הכתובת
                byte low = reader.ReadByte();
                byte high = reader.ReadByte();
                loadAddress = (ushort)(low | (high << 8));

                // קריאת שאר הנתונים הבינאריים של הספרייט
                int remainingLength = (int)(reader.BaseStream.Length - 2);
                return reader.ReadBytes(remainingLength);
            }
        }

        // ==========================================
        // 3. פורמט קואלה (Koala Painter Format)
        // פורמט מורכב יותר שכולל לרוב Bitmap, Screen RAM, Color RAM ורקע
        // ==========================================
        public static void SaveAsKoala(string filePath, byte[] spriteData, byte backgroundColor)
        {
            // כאן תכניס את לוגיקת האריזה של קואלה שכבר כתבת
            // (למשל הוספת הכתובת $6000 בראש, נתוני מסך, צבעים וכו')
        }

        public static byte[] LoadFromKoala(string filePath, out byte backgroundColor)
        {
            backgroundColor = 0;
            // כאן תכניס את לוגיקת הפירוק של קובץ קואלה שכבר כתבת
            return null;
        }

    }
}
