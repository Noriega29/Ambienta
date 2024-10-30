namespace Ambienta.Services.Tests
{
    public class NovenoTest
    {
        public object SintesisDeProteinasTest(char question1, char question2, char question3, char question4, char question5, char question6, char question7, char question8, char question9, char question10)
        {
            // Cantidad de preguntas
            int questions = 10;

            List<int> right = new List<int>();
            List<int> mistake = new List<int>();

            // Array de las respuestas correctas
            char[] correctAnswers = { 'b', 'c', 'c', 'b', 'a', 'c', 'c', 'c', 'b', 'c' };
            // Array de las respuestas del usuario
            char[] userAnswers = { question1, question2, question3, question4, question5, question6, question7, question8, question9, question10 };
            // Revisar cada respuesta
            for (int i = 0; i < correctAnswers.Length; i++)
            {
                if (userAnswers[i] == correctAnswers[i])
                {
                    right.Add(i + 1); // Respuesta correcta
                }
                else
                {
                    mistake.Add(i + 1);// Respuesta incorrecta
                }
            }

            // Verificar si el usuario aprobó (por ejemplo, si respondió correctamente al 80% de las preguntas)
            bool aprobado = right.Count == questions; // Aprobado si tiene al menos 8 respuestas correctas de 8

            // Crear el objeto de respuesta
            var result = new
            {
                aprobado = aprobado,
                question1 = correctAnswers[0],
                question2 = correctAnswers[1],
                question3 = correctAnswers[2],
                question4 = correctAnswers[3],
                question5 = correctAnswers[4],
                question6 = correctAnswers[5],
                question7 = correctAnswers[6],
                question8 = correctAnswers[7],
                question9 = correctAnswers[8],
                question10 = correctAnswers[9],
                mensaje = aprobado ? "¡Felicidades! Aprobaste." : "Lo siento, no aprobaste. Sigue practicando."
            };

            // Devolver el resultado como JSON
            return result;
        }

        public object LeyesDeMendelTest(char question1, char question2, char question3, char question4, char question5, char question6, char question7, char question8, char question9, char question10)
        {
            // Cantidad de preguntas
            int questions = 10;

            List<int> right = new List<int>();
            List<int> mistake = new List<int>();

            // Array de las respuestas correctas
            char[] correctAnswers = { 'a', 'b', 'b', 'a', 'c', 'c', 'b', 'c', 'b', 'b' };
            // Array de las respuestas del usuario
            char[] userAnswers = { question1, question2, question3, question4, question5, question6, question7, question8, question9, question10 };
            // Revisar cada respuesta
            for (int i = 0; i < correctAnswers.Length; i++)
            {
                if (userAnswers[i] == correctAnswers[i])
                {
                    right.Add(i + 1); // Respuesta correcta
                }
                else
                {
                    mistake.Add(i + 1);// Respuesta incorrecta
                }
            }

            // Verificar si el usuario aprobó (por ejemplo, si respondió correctamente al 80% de las preguntas)
            bool aprobado = right.Count == questions; // Aprobado si tiene al menos 8 respuestas correctas de 8

            // Crear el objeto de respuesta
            var result = new
            {
                aprobado = aprobado,
                question1 = correctAnswers[0],
                question2 = correctAnswers[1],
                question3 = correctAnswers[2],
                question4 = correctAnswers[3],
                question5 = correctAnswers[4],
                question6 = correctAnswers[5],
                question7 = correctAnswers[6],
                question8 = correctAnswers[7],
                question9 = correctAnswers[8],
                question10 = correctAnswers[9],
                mensaje = aprobado ? "¡Felicidades! Aprobaste." : "Lo siento, no aprobaste. Sigue practicando."
            };

            // Devolver el resultado como JSON
            return result;
        }
    }
}
