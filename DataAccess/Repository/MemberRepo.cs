using DataAccess.Models;

namespace DataAccess.Repository;

public class MemberRepo : IMemberRepo
{
    public void AddMember(Member member)
    {
        try
        {
            using var dbContext = new FStoreDBContext();
            dbContext.Members.Add(member);
            dbContext.SaveChanges();
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
            using var dbContext = new FStoreDBContext();
            var member = dbContext.Members.Find(id);
            dbContext.Members.Remove(member);
            dbContext.SaveChanges();
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
            using var dbContext = new FStoreDBContext();
            return dbContext.Members.ToList();
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
            using var dbContext = new FStoreDBContext();
            return dbContext.Members.Find(id);
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
            using var dbContext = new FStoreDBContext();
            dbContext.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
