using System;

namespace Cross.Model.RequestSystem
{
    public interface IRequest
    {
        public int Id { get; set; }

        public int StatusId { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modifed { get; set; }
    }
}
