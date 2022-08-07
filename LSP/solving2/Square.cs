
namespace LSP.solving2
{
    public class Square : Shape
    {
        private int size;
        public Square(int size)
        {
            this.size = size;
        }
        public void setSize(int size) => this.size = size;
        public long Area() => size * size;
    }
}
