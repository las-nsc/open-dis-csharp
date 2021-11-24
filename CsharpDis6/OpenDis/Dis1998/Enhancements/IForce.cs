namespace OpenDis.Dis1998
{
    public interface IForce
    {
        byte ForceID { get; set; }
    }

    public partial class EntityStatePdu : IForce
    {
        byte IForce.ForceID { get => ForceId; set => ForceId = value; }
    }
    public partial class FastEntityStatePdu : IForce
    {
        byte IForce.ForceID { get => ForceId; set => ForceId = value; }
    }
    public partial class AggregateStatePdu : IForce { }
    public partial class FastEntityStatePdu : IForce { }
    public partial class ArealObjectStatePdu : IForce { }
    public partial class LinearObjectStatePdu : IForce { }
    public partial class MinefieldStatePdu : IForce { }
    public partial class PointObjectStatePdu : IForce { }
}
