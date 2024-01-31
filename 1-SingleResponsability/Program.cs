using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.exportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");