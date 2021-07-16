using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IOrganizationRepository _organizationRepository;
        private IUserRepository _userRepository;
        private ISectionEnrollmentRepository _sectionenrollmentRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IOrganizationRepository Organization
        {
            get
            {
                if (_organizationRepository == null)
                    _organizationRepository = new OrganizationRepository(_repositoryContext);

                return _organizationRepository;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_repositoryContext);

                return _userRepository;
            }
        }
        public ISectionEnrollmentRepository SectionEnrollment
        {
            get
            {
                if (_sectionenrollmentRepository == null)
                    _sectionenrollmentRepository = new SectionEnrollmentRepository(_repositoryContext);

                return _sectionenrollmentRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}
