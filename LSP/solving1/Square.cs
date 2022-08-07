namespace LSP.solving1
{
    public class Square : Rectangle
    {
        public Square() { }
        public Square(int side) : base(side, side) { }
        public new void setShortSide(int shortSide) => this.longSide = this.shortSide = shortSide;
        public new void setLongSide(int longSide) => this.longSide = this.shortSide = longSide;
    }
}
