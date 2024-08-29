using BusinessLogicLayer.Models;
using BusinessLogicLayer.Resoures;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mapping
{
    public static class UserMapping
    {
        public static User ToEntity(this UserModel model) =>
            new User
            {
                Id = model.Id,
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                Phone = model.Phone,
                IsActive = model.IsActive,
                CompanyId = model.CompanyId
            };

        public static UserModel ToModel(this User entity) =>
            new UserModel
            {
                Id = entity.Id,
                UserName = entity.UserName,
                Email = entity.Email,
                Password = entity.Password,
                Phone = entity.Phone,
                IsActive = entity.IsActive,
                CompanyId = entity.CompanyId
            };

        public static UserResource ToResource(this User entity) =>
    new UserResource
    {
        Id = entity.Id,
        UserName = entity.UserName,
        Email = entity.Email,
        Phone = entity.Phone,
        IsActive = entity.IsActive,
        Company = entity.Company != null ? new CompanyResource
        {
            Id = entity.Company.Id,
            Name = entity.Company.Name,
            Phone = entity.Company.Phone,
            Email = entity.Company.Email,
            Address = entity.Company.Address,
            ProfilePicture = entity.Company.ProfilePicture,
            IsCustomer = entity.Company.IsCustomer
        } : null,
    };

    }
}
