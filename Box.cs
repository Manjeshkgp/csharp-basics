using System;

namespace Properties
{
    class Box
    {
        // member variable
        private int length = 3; // initial value is 3;
        private int height;
        // private int width;
        // public int volume;

        // property
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public int Width { get; set; }

        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should not be lesser than 0");
            }
            this.length = length;
        }

        public int Volume
        {
            get
            {
                return length * Width * height;
            }
        }

        public int GetLength()
        {
            return length;
        }

        public void DisplayInfo()
        {
            System.Console.WriteLine("Length is {0}, height is {1}, width is {2} & volume is {3}",
                length, height, Width,
                length * height * Width
            );
        }
    }
}