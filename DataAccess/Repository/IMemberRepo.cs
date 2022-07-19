using DataAccess.Models;

namespace DataAccess.Repository;

public interface IMemberRepo
{
    public Member GetMember(int id);
    public IEnumerable<Member> GetList();
    public void AddMember(Member member);
    public void UpdateMember(Member member);
    public void DeleteMember(int id);
}
