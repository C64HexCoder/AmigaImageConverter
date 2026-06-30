using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public abstract class BaseSprite
    {
        // פרופרטיז וירטואליים - מאפשרים ליורשים לשנות את מה שהם מחזירים!
        public virtual int Width { get; protected set; }
        public virtual int Height { get; protected set; }

        // המטריצה האמיתית בזיכרון תמיד בגודל הפיזי המלא
        protected int[,] pixelMatrix;

        protected BaseSprite(int maxWidth, int maxHeight)
        {
            pixelMatrix = new int[maxWidth, maxHeight];
        }

        // אינדקסר ברירת מחדל פשוט (גישה ישירה אחד-לאחד לפיקסל)
        public virtual int this[int x, int y]
        {
            get { return pixelMatrix[x, y]; }
            set { pixelMatrix[x, y] = value; }
        }

        public abstract byte[] GetRawBytes();
    }
}
