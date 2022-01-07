namespace Cross.Model.RequestSystem
{
    public interface IRequestActionStatus
    {
        public int Id { get; set; }

        public int ActionId { get; set; }

        public int StatusId { get; set; }
    }
}
