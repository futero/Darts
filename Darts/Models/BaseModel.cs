using System;

namespace Darts.Models
{
    public class BaseModel
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime InsertDateTime { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public Guid Guid { get; set; }

        public BaseModel()
        {
            this.Guid = Guid.NewGuid();
        }

        public void Create()
        {

        }

        public void Read()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}