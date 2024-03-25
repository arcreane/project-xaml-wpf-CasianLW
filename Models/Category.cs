
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Category {

    public Category() {
    }

    //public void Id;

    //public void Name;

    //public void Description;

    //public void ToolId;

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public virtual ICollection<Tool> Tools { get; set; }

    public void AddCategory() {
        // TODO implement here
    }

    public void ViewCategory() {
        // TODO implement here
    }

    public void ListCategories() {
        // TODO implement here
    }

    public void EditCategory() {
        // TODO implement here
    }

}