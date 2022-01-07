namespace Cross.Model.RequestSystem
{
    public interface IRequestAction<TRoleId>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string NameMUI { get; set; }

        public string ConfirmationMUI { get; set; }

        public string SuccessMUI { get; set; }

        public int SetStatusId { get; set; }

        public TRoleId RoleId { get; set; }
    }
}
