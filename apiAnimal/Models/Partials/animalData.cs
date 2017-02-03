using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace apiAnimal.Models
{
    [MetadataType(typeof(animalDataMD))]
    public partial class animalData
    {
        public class animalDataMD
        {
            public int animalID { get; set; }
            public string animalKind { get; set; }
            public string animalType { get; set; }
            public string animalName { get; set; }
            public string animalAddress { get; set; }
            public string animalDate { get; set; }
            public string animalGender { get; set; }
            public Nullable<int> animalAge { get; set; }
            public string animalColor { get; set; }
            public string animalBirth { get; set; }
            public string animalChip { get; set; }
            public string animalHealthy { get; set; }
            public string animalDisease_Other { get; set; }
            public string animalOwner_userID { get; set; }
            public string animalReason { get; set; }
            public string animalGetter_userID { get; set; }
            public string animalAdopted { get; set; }
            public string animalAdoptedDate { get; set; }
            public string animalNote { get; set; }

          
            public IQueryable<animalData_Pic> animalData_Pic { get; set; }
            
            public IQueryable<animalData_Condition> animalData_Condition { get; set; }

 
        }
    }
}