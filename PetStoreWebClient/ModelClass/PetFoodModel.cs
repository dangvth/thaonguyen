﻿using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreWebClient.ModelClass
{
    public class PetFoodModel
    {
        PetStoreOnlineDbContext db = null;
        public PetFoodModel()
        {
            db = new PetStoreOnlineDbContext();
        }

        /// <summary>
        /// get pet's food by id
        /// </summary>
        /// <param name="pfID"></param>
        /// <returns></returns>
        public PetFood getPetFoodByID(String pfID)
        {
            return db.PetFood.Find(pfID);
        }

        /// <summary>
        /// get Pet by ID
        /// </summary>
        /// <param name="pID"></param>
        /// <returns></returns>
        public Pet getPetByID(String pID)
        {
            return db.Pet.Find(pID);
        }

        /// <summary>
        /// get Pet medicine by ID
        /// </summary>
        /// <param name="pmID"></param>
        /// <returns></returns>
        public PetMedicine getPetMedicineByID(String pmID)
        {
            return db.PetMedicine.Find(pmID);
        }

        /// <summary>
        /// get Pet toys by ID
        /// </summary>
        /// <param name="ptID"></param>
        /// <returns></returns>
        public PetToys getPetToyByID(String ptID)
        {
            return db.PetToys.Find(ptID);
        }

        /// <summary>
        /// get related pet food in sale off
        /// </summary>
        /// <param name="pfID"></param>
        /// <returns></returns>
        public List<PetFood> getPetFoodRelated(String pfID)
        {
            return db.PetFood.Where(x => x.pf_id != pfID).Take(4).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<PetFood> getAllPetFood(ref int totalRecord, int pageIndex = 1, int pageSize = 2)
        {
            totalRecord = db.PetFood.Where(x => x.pf_status == "Active").Count();
            var model = db.PetFood.Where(x => x.pf_status == "Active").OrderBy(x => x.pf_id).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return model;
        }
    }
}