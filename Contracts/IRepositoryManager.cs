namespace Contracts
{
    public interface IRepositoryManager
    {
        IOrganizationRepository Organization { get; }
        IUserRepository User { get; }
        ISectionEnrollmentRepository SectionEnrollment { get; }

        void Save();
    }
}
