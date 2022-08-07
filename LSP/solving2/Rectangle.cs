namespace LSP.solving2
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;           
        }

        public void setWidth(int width) => this.width = width;
        public void setHeight(int height) => this.height = height;
        public long Area() => width * height;
    }
}
