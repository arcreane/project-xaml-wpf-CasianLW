
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class User : Inventorry {

    public int Id { get; set; }
    public string Name { get; set; }
    public RoleEnum Role { get; set; } 
    public string Email { get; set; }
    public string Password { get; set; }

    public User() {

    }

    //public void Id;

    //public string Name;

    //public RoleEnum Role;

    //public void Email;

    //private void Password;

    public void Authenticate() {
        // TODO implement here
    }

    public void ChangePassword() {
        // TODO implement here
    }

    public void UpdateInfos() {
        // TODO implement here
    }

    public void GetPasswordHash() {
        // TODO implement here
    }

    public void SetPasswordHash() {
        // TODO implement here
    }

    /// <summary>
    /// @param RoleEnum
    /// </summary>
    public void AssignRole(void RoleEnum) {
        // TODO implement here
    }

}