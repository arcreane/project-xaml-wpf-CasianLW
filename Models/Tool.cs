
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Tool {

    public Tool() {
    }



    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public StatusEnum Status { get; set; }

    public virtual Category Category { get; set; }


    //public void Id;

    //public void Name;

    //public void CategoryId;

    //public void Status;

    //public void UserAssignedId;

    //public string QRImage;

    /// <summary>
    /// @param Parameter1 
    /// @return
    /// </summary>
    public int truc(User Parameter1) {
        // TODO implement here
        return 0;
    }

    public void CheckStatus() {
        // TODO implement here
    }

    public void AssignToUser() {
        // TODO implement here
    }

    public void RemoveFromUser() {
        // TODO implement here
    }

    public void GenerateQRCode() {
        // TODO implement here
    }

}