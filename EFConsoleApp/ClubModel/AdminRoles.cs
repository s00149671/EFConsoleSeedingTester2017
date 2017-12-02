//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

///namespace ClubModel
//{
    //public class AdminRoles
   // {
       // private void addRolesforAdmins(ClubContext context)
       // {
    //
            // Assumes student has been seeded as an application user
           // List<Club> admins = context.Clubs.Include("clubMembers").ToList();

            // Get the members who are admins
            //var adminMembers = (from admin in admins
                               // join member in context.members.ToList()
                                //on admin.adminID equals member.memberID
                                //select member);
            // Get the aplication users 
            // Match them by studentID
            // add a role

            //using (ApplicationDbContext db = new ApplicationDbContext())
           // {
               // var manager =
               // new UserManager<ApplicationUser>(
               // new UserStore<ApplicationUser>(db));
                // iterate over the admin members and add a role for them
               // foreach (var item in adminMembers)
                //{
                   // ApplicationUser user = db.Users
                                //.FirstOrDefault(u => u.StudentID == item.StudentID);
                  //  if (user != null)
                       // manager.AddToRole(user.Id, "ClubAdmin");
                //}
                //db.SaveChanges();
         //   }

      //  }
   // }

