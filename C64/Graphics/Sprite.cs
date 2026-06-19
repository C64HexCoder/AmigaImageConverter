using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace C64.Graphics
{
    public class Sprite
    {
        public const int Width = 24;
        public const int Height = 21;
        public const int TotalBytes = 64;

        // מערך חד-ממדי קשיח של 64 בתים - בדיוק כמו בחומרה של ה-C64
        public byte[] RawData { get; private set; } = new byte[TotalBytes];

        // אינדקסר חכם שמפרק את הביטים של ה-64 בתים ל-X ו-Y פיקסלים עבור הפקד!
        public bool this[int x, int y]
        {
            get
            {
                if (x < 0 || x >= Width || y < 0 || y >= Height) return false;

                // חישוב באיזה בית מתוך ה-63 נמצא הפיקסל (3 בתים לכל שורה)
                int byteIndex = (y * 3) + (x / 8);
                // חישוב הביט הספציפי בתוך הבית (משמאל לימין)
                int bitIndex = 7 - (x % 8);

                return (RawData[byteIndex] & (1 << bitIndex)) != 0;
            }
            set
            {
                if (x < 0 || x >= Width || y < 0 || y >= Height) return;

                int byteIndex = (y * 3) + (x / 8);
                int bitIndex = 7 - (x % 8);

                if (value)
                {
                    RawData[byteIndex] |= (byte)(1 << bitIndex);  // הדלקת הביט
                }
                else
                {
                    RawData[byteIndex] &= (byte)~(1 << bitIndex); // כיבוי הביט
                }
            }
        }

        // פונקציות שמירה וטעינה מהירות בליין אחד בלי שום המרות
        public void SaveToFile(string filePath)
        {
            File.WriteAllBytes(filePath, RawData);
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return;
            byte[] loadedData = File.ReadAllBytes(filePath);
            if (loadedData.Length >= TotalBytes)
            {
                Array.Copy(loadedData, RawData, TotalBytes);
            }
        }

        public void SaveSpriteAsPRG (string filePath,ushort address)
        {
            Stream stream = new FileStream (filePath, FileMode.Create);
            BinaryWriter binaryWriter = new BinaryWriter(stream);

            binaryWriter.Write (Endian.Convert(address));

            for (int i = 0; i < TotalBytes; i++)
            {
                binaryWriter.Write (RawData[i]);
            }

            binaryWriter.Flush() ; 
            binaryWriter.Close();
        }
    }
}