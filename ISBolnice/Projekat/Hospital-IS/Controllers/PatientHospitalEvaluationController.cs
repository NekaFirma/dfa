using ClinicCore.DTOs;
using ClinicCore.Model;
using ClinicCore.Service;

namespace Hospital_IS.Controllers
{
    public class PatientHospitalEvaluationController
    {
        private static PatientHospitalEvaluationController instance = null;
        public static PatientHospitalEvaluationController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PatientHospitalEvaluationController();
                }
                return instance;
            }
        }

        private PatientHospitalEvaluationController()
        {
        }

        public void AddHospitalEvaluation(HospitalEvaluationDTO hospitalEvaluationDTO)
        {
            PatientHospitalEvaluationService.Instance.AddHospitalEvaluation(new PatientHospitalEvaluation(hospitalEvaluationDTO.Grade, hospitalEvaluationDTO.Comment, hospitalEvaluationDTO.Date, hospitalEvaluationDTO.PatientId));
        }
    }
}
