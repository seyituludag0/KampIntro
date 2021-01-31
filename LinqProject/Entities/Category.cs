using LinqProject.Abstract;

namespace LinqProject.Entities
{
    class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}