namespace LSP.solving1
{
    public class Rectangle
    {
		protected int shortSide, longSide;		

		public Rectangle(){}
		public Rectangle(int shortSide, int longSide)
		{
            this.shortSide = shortSide;
			this.longSide = longSide;
		}
        public double calculateArea() => shortSide * longSide;
        public double calculateCircumference() => 2 * (shortSide + longSide);
        public void setShortSide(int shortSide) => this.shortSide = shortSide;
        public void setLongSide(int longSide) => this.longSide = longSide;
    }
}
