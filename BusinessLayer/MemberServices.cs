using DataAccess.Models;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;

namespace BusinessLayer;

public class MemberServices : IMemberServices
{
    private bool checkAdmin(string email, string password)
    {
        bool result = false;

        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        Console.WriteLine(config.GetSection("AdminUsers").Value);
        string adminEmail = config["AdminUsers:Email"];
        string adminPassword = config["AdminUsers:Password"];
        if (adminEmail == email && adminPassword == password)
        {
            result = true;
        }
        return result;
    }
    public void AddMember(Member member)
    {
        try
        {
            IMemberRepo memberRepo = new MemberRepo();
            memberRepo.AddMember(member);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void DeleteMember(int id)
    {
        try
        {
            IMemberRepo memberRepo = new MemberRepo();
            memberRepo.DeleteMember(id);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public IEnumerable<Member> GetList()
    {
        try
        {
            IMemberRepo memberRepo = new MemberRepo();
            return memberRepo.GetList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Member GetMember(int id)
    {
        try
        {
            IMemberRepo memberRepo = new MemberRepo();
            return memberRepo.GetMember(id);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Member Login(string email, string password)
    {
        if (checkAdmin(email, password) == true)
        {
            return new Member
            {
                MemberId = 0,
                Email = email,
                Password = password,
            };
        }
        else try
        {
            IMemberRepo memberRepo = new MemberRepo();
            var member = (from mem in memberRepo.GetList()
                         where mem.Email == email
                         select mem).First();
            if (member == null)
            {
                if (member.Password == password)
                {
                    return member;
                }
                else
                {
                    throw new Exception("Incorrect password!");
                }
            }
            else
            {
                throw new Exception("No user found!");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void UpdateMember(Member member)
    {
        try
        {
            IMemberRepo memberRepo = new MemberRepo();
            memberRepo.UpdateMember(member);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
