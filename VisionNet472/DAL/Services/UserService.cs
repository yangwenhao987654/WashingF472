using System.Collections.Generic;
using VisionNet472.DAL.Entity;
using VisionNet472.DAL.Repositories;

namespace VisionNet472.DAL.Services
{
    public class UserService
    {
        private readonly Repository<OpUser> _repository;
        public UserService(Repository<OpUser> repository)
        {
            _repository = repository;
        }

        public void AddUser(OpUser user)
        {
            _repository.Insert(user);
        }

        public List<OpUser> GetAllUsers()
        {
            return _repository.GetAll();
        }

        public OpUser GetUserById(int id)
        {
            return _repository.GetById(id);
        }


        public void DeleteUser(int id)
        {
            _repository.Delete(id);
        }
    }
}
