using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace apiAnimal.Models
{
    [MetadataType(typeof(animalData_TypeMD))]
    public partial class animalData_Type
    {
        public class animalData_TypeMD
        {
            
            public int animalTypeID { get; set; }
            public string animalKind { get; set; }
            public string animalType { get; set; }

        }
    }
}