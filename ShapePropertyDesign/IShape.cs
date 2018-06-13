namespace ShapePropertyDesign
{
    enum MovePosition
    {
        Left,
        Right,
        Up,
        Down
    }
    interface IShape
    {
        // Original Coordinate
        double X { get; set; }  
        double Y { get; set; }
        double Area { get;  }
        double Parimeter { get;  }
        string ToString();
        void Move(MovePosition position);
    }
}