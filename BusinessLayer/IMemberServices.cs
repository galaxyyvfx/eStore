using DataAccess.Models;

namespace BusinessLayer;

public interface IMemberServices
{
    public Member GetMember(int id);
    public Member Login(string email, string password);
    public IEnumerable<Member> GetList();
    public void AddMember(Member member);
    public void UpdateMember(Member member);
    public void DeleteMember(int id);
}
