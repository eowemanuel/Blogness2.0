﻿using System;
using System.Collections.Generic;
using System.Linq;
using Blog.Backend.Common.Contracts;
using Blog.Backend.DataAccess.Repository;
using Blog.Backend.Logic.Mapper;

namespace Blog.Backend.Logic
{
    public class EducationLogic
    {
        private readonly IEducationRepository _educationRepository;

        public EducationLogic(IEducationRepository educationRepository)
        {
            _educationRepository = educationRepository;
        }

        public List<Education> GetByUser(int userId)
        {
            var education = new List<Education>();
            try
            {
                var db = _educationRepository.Find(a => a.UserId == userId, true).ToList();
                db.ForEach(a => education.Add(EducationMapper.ToDto(a)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return education;
        }

        public bool Add(Education education)
        {
            try
            {
                _educationRepository.Add(EducationMapper.ToEntity(education));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Education education)
        {
            try
            {
                 _educationRepository.Edit(EducationMapper.ToEntity(education));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int educationId)
        {
            try
            {
                _educationRepository.Delete(_educationRepository.Find(a => a.EducationId == educationId, false).FirstOrDefault());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
