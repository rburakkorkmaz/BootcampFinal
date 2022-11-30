namespace EntityLayer.Concrete.PetVM
{
    public class PetPutDTO
    {

        public string? Name { get; set; }


        public string? Breed { get; set; }


        public string? Species { get; set; }


        public int? Age { get; set; }


        public string Health { get; set; }


        public bool IsMissing { get; set; }


        public string? Description { get; set; }

        public int UserId { get; set; }

    }
}
