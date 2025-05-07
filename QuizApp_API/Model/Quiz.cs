using System.ComponentModel.DataAnnotations.Schema;

public class Quiz
{
    public int QuizId { get; set; }
    public string Question { get; set; }
    public string AnswerString { get; set; }

    [NotMapped]
    public string[] Answer
    {
        get => AnswerString?.Split(';');
        set => AnswerString = string.Join(';', value);
    }

    public int CorrectAnswerIndex { get; set; }
}
