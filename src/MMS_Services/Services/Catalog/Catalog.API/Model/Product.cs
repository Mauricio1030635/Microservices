namespace Catalog.API.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        //(Asignación de valor por defecto con operador de supresión de advertencias)
        //!: Este símbolo es el operador de supresión de advertencias de nulabilidad.
        public string Name { get; set; } = default!;
        //siempre estará inicializada con una nueva lista vacía
        public List<string> Category { get; set; } = new();
        public string Description { get; set; } = default!;
        public string ImageFile{ get; set; } = default!;
        public decimal Price { get; set; } = default!;



    }
}
