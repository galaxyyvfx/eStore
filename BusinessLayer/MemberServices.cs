using DataAccess.Models;
using DataAccess.Repository;

namespace BusinessLayer;

public class MemberServices : IMemberServices
{
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
        try
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
