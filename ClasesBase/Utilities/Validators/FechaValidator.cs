using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.Utilities.Validators
{
    public static class FechaValidator
    {
        public class ValidationResult
        {
            public bool IsValid { get; set; }
            public string ErrorMessage { get; set; }

            public ValidationResult(bool isValid, string errorMessage = "")
            {
                IsValid = isValid;
                ErrorMessage = errorMessage;
            }
        }

        public static ValidationResult ValidarFecha(DateTime fecha)
        {
            if (fecha == DateTime.MinValue)
                return new ValidationResult(false, "La fecha no es válida");

            return new ValidationResult(true);
        }

        public static ValidationResult ValidarFechaFutura(DateTime fecha, String tipoFecha)
        {
            var resultado = ValidarFecha(fecha);
            if (!resultado.IsValid)
                return resultado;

            if (fecha < DateTime.Today)
                return new ValidationResult(false, "La fecha " + tipoFecha +" no puede ser anterior al día actual");

            return new ValidationResult(true);
        }

        public static ValidationResult ValidarFechaPasada(DateTime fecha)
        {
            var resultado = ValidarFecha(fecha);
            if (!resultado.IsValid)
                return resultado;

            if (fecha > DateTime.Today)
                return new ValidationResult(false, "La fecha no puede ser futura");

            return new ValidationResult(true);
        }

        public static ValidationResult ValidarRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            var resultadoInicio = ValidarFecha(fechaInicio);
            if (!resultadoInicio.IsValid)
                return new ValidationResult(false, "Fecha de inicio inválida");

            var resultadoFin = ValidarFecha(fechaFin);
            if (!resultadoFin.IsValid)
                return new ValidationResult(false, "Fecha de fin inválida");

            if (fechaInicio > fechaFin)
                return new ValidationResult(false, "La fecha de inicio no puede ser posterior a la fecha de fin");

            return new ValidationResult(true);
        }

        public static ValidationResult ValidarEdadMinima(DateTime fechaNacimiento, int edadMinima)
        {
            var resultado = ValidarFecha(fechaNacimiento);
            if (!resultado.IsValid)
                return resultado;

            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (fechaNacimiento > DateTime.Today.AddYears(-edad))
                edad--;

            if (edad < edadMinima)
                return new ValidationResult(false, "Debe tener al menos "+ edadMinima+ " años");

            return new ValidationResult(true);
        }

        // Versión simple que solo retorna bool
        public static bool IsValidFecha(DateTime fecha)
        {
            return fecha != DateTime.MinValue;
        }

        public static bool IsValidFechaFutura(DateTime fecha)
        {
            return IsValidFecha(fecha) && fecha >= DateTime.Today;
        }

        public static bool IsValidFechaPasada(DateTime fecha)
        {
            return IsValidFecha(fecha) && fecha <= DateTime.Today;
        }

        public static bool IsValidRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return IsValidFecha(fechaInicio) && IsValidFecha(fechaFin) && fechaInicio <= fechaFin;
        }
    }
}
