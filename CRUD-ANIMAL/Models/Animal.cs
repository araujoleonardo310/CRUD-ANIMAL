using System.ComponentModel.DataAnnotations;

namespace DesenvolvendoCRUDdeAnimal.Models {
    public class Animal {
        [Key]
        public int ANI_COD { get; set; }
        public string? NOME { get; set; }
        public int IDADE { get; set; }
        public int JAU_COD { get; set; }
    }
}
