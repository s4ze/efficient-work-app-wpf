namespace EfficientWorkApp.Models
{
    public class WarmupItem : Item
    {
        private string fT;
        private string sMT;
        private string sST;
        public override string firstText { get { return fT; } set { fT = value; } }
        public override string secondMainText { get { return sMT; } set {sMT = value; } }
        public override string secondSecondaryText { get { return sST; } set {sST = value; } }
    }
}
