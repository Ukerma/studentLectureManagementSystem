<h1>📚 StudentLectureManagementSystem</h1>

<p>StudentLectureManagementSystem is a console-based application designed to manage students, instructors, and courses efficiently. The application allows users to add students and instructors, create courses, assign courses to students, and list enrolled students for a specific course.</p>

<h2>🌟 Features</h2>
<ul>
    <li> Add new students with unique IDs.</li>
    <li> Add instructors with department information.</li>
    <li> Create courses and assign instructors to them.</li>
    <li> Enroll students in courses.</li>
    <li> List students enrolled in a specific course.</li>
</ul>

<h2>💻 Technical Details</h2>
<ul>
    <li> Developed using <b>C#</b>.</li>
    <li> Utilizes object-oriented programming principles including inheritance, interfaces, and abstraction.</li>
    <li> Data is stored in in-memory lists for simplicity.</li>
</ul>

<h2>🛠️ How to Use</h2>
<ol>
    <li>Run the application in a C# IDE or terminal.</li>
    <li>Navigate the menu to add students, instructors, and courses.</li>
    <li>Assign courses to students and view their enrollment details.</li>
    <li>Exit the application when finished.</li>
</ol>

<h2>📂 Project Structure</h2>
<p>The project consists of the following classes:</p>
<ul>
    <li>
        <b>Person (Abstract Class):</b>  
        Represents a base class for all individuals in the system. Contains common properties such as:
        <ul>
            <li><code>FirstName</code>: The first name of the person.</li>
            <li><code>LastName</code>: The last name of the person.</li>
            <li><code>ID</code>: A unique identifier.</li>
        </ul>
        Includes the abstract method <code>DisplayInfo()</code>, which is implemented by derived classes.
    </li>
    <li>
        <b>IPerson (Interface):</b>  
        Defines a contract for person-related operations, such as:
        <ul>
            <li><code>GetFullName()</code>: Returns the full name of the individual.</li>
        </ul>
    </li>
    <li>
        <b>Student (Class):</b>  
        Inherits from <code>Person</code> and implements <code>IPerson</code>. Additional properties include:
        <ul>
            <li><code>StudentID</code>: A unique student identifier.</li>
            <li><code>EnrolledCourses</code>: A list of courses the student is enrolled in.</li>
        </ul>
        Implements the <code>DisplayInfo()</code> method to print student details.
    </li>
    <li>
        <b>Instructor (Class):</b>  
        Inherits from <code>Person</code> and implements <code>IPerson</code>. Additional properties include:
        <ul>
            <li><code>Department</code>: The department the instructor belongs to.</li>
            <li><code>TaughtCourses</code>: A list of courses taught by the instructor.</li>
        </ul>
        Implements the <code>DisplayInfo()</code> method to print instructor details.
    </li>
    <li>
        <b>Course (Class):</b>  
        Represents a course in the system. Contains properties like:
        <ul>
            <li><code>CourseName</code>: The name of the course.</li>
            <li><code>Credits</code>: The credit value of the course.</li>
            <li><code>Instructor</code>: The instructor teaching the course.</li>
            <li><code>EnrolledStudents</code>: A list of students enrolled in the course.</li>
        </ul>
        Includes the <code>DisplayCourseInfo()</code> method to print course details.
    </li>
    <li>
        <b>Program (Main Class):</b>  
        Manages the overall functionality of the system, including:
        <ul>
            <li>Adding students, instructors, and courses.</li>
            <li>Assigning courses to students.</li>
            <li>Listing students enrolled in a specific course.</li>
        </ul>
        Uses a menu-driven interface to interact with the user.
    </li>
</ul>

<h2>👨‍💻 Author</h2> <p> This project was created by <strong>Umut Kerim ACAR (ukerma)</strong>. </p>

<h1>📖 Açıklama (Türkçe)</h1>

<p>StudentLectureManagementSystem, öğrencileri, eğitmenleri ve dersleri verimli bir şekilde yönetmek için tasarlanmış bir konsol tabanlı uygulamadır. Kullanıcıların öğrenci ve eğitmen eklemesine, ders oluşturarak öğrencilere atamasına ve belirli bir ders için kaydolmuş öğrencileri listelemesine olanak tanır.</p>

<h2>🌟 Özellikler</h2>
<ul>
    <li> Benzersiz ID'lerle yeni öğrenciler ekleme.</li>
    <li> Bölüm bilgisiyle eğitmenler ekleme.</li>
    <li> Dersler oluşturup eğitmenleri bu derslere atama.</li>
    <li> Öğrencileri derslere kaydetme.</li>
    <li> Belirli bir derse kaydolmuş öğrencileri listeleme.</li>
</ul>

<h2>💻 Teknik Detaylar</h2>
<ul>
    <li> <b>C#</b> kullanılarak geliştirildi.</li>
    <li> Kalıtım, arabirimler ve soyutlama gibi nesne yönelimli programlama prensiplerini kullanır.</li>
    <li> Veriler basitlik amacıyla bellek içinde listelerde saklanır.</li>
</ul>

<h2>🛠️ Nasıl Kullanılır</h2>
<ol>
    <li>Uygulamayı bir C# IDE'si veya terminalde çalıştırın.</li>
    <li>Menüde gezinerek öğrenci, eğitmen ve ders ekleyin.</li>
    <li>Dersleri öğrencilere atayın ve kayıt detaylarını görüntüleyin.</li>
    <li>İşlem bitince uygulamadan çıkın.</li>
</ol>

<h2>📂 Proje Yapısı</h2>
<p>Proje şu sınıflardan oluşmaktadır:</p>
<ul>
    <li>
        <b>Person (Soyut Sınıf):</b>  
        Sistem içerisindeki tüm bireyler için temel sınıf olarak görev yapar. Şu özellikleri içerir:
        <ul>
            <li><code>FirstName</code>: Kişinin adı.</li>
            <li><code>LastName</code>: Kişinin soyadı.</li>
            <li><code>ID</code>: Benzersiz kimlik numarası.</li>
        </ul>
        <code>DisplayInfo()</code> soyut metodu türetilen sınıflar tarafından uygulanır.
    </li>
    <li>
        <b>IPerson (Arayüz):</b>  
        Kişi ile ilgili işlemler için bir sözleşme sağlar. Şu metodu içerir:
        <ul>
            <li><code>GetFullName()</code>: Kişinin tam adını döndürür.</li>
        </ul>
    </li>
    <li>
        <b>Student (Sınıf):</b>  
        <code>Person</code> sınıfından türetilir ve <code>IPerson</code> arayüzünü uygular. Ek özellikler:
        <ul>
            <li><code>StudentID</code>: Öğrenciye özgü kimlik numarası.</li>
            <li><code>EnrolledCourses</code>: Öğrencinin kayıtlı olduğu derslerin listesi.</li>
        </ul>
        <code>DisplayInfo()</code> metodu öğrenci bilgilerini yazdırır.
    </li>
    <li>
        <b>Instructor (Sınıf):</b>  
        <code>Person</code> sınıfından türetilir ve <code>IPerson</code> arayüzünü uygular. Ek özellikler:
        <ul>
            <li><code>Department</code>: Eğitmenin çalıştığı bölüm.</li>
            <li><code>TaughtCourses</code>: Eğitmenin verdiği derslerin listesi.</li>
        </ul>
        <code>DisplayInfo()</code> metodu eğitmen bilgilerini yazdırır.
    </li>
    <li>
        <b>Course (Sınıf):</b>  
        Sistemdeki bir dersi temsil eder. Özellikler:
        <ul>
            <li><code>CourseName</code>: Dersin adı.</li>
            <li><code>Credits</code>: Dersin kredi değeri.</li>
            <li><code>Instructor</code>: Dersi veren eğitmen.</li>
            <li><code>EnrolledStudents</code>: Derse kayıtlı öğrencilerin listesi.</li>
        </ul>
        <code>DisplayCourseInfo()</code> metodu ders detaylarını yazdırır.
    </li>
    <li>
        <b>Program (Ana Sınıf):</b>  
        Sistemin genel işlevselliğini yönetir. Şunları içerir:
        <ul>
            <li>Öğrenci, eğitmen ve ders ekleme.</li>
            <li>Dersleri öğrencilere atama.</li>
            <li>Belirli bir derse kayıtlı öğrencileri listeleme.</li>
        </ul>
        Kullanıcı ile etkileşim için menü tabanlı bir arayüz kullanır.
    </li>
</ul>

<h2>👨‍💻 Yazar</h2> <p> Bu proje, <strong>Umut Kerim ACAR (ukerma)</strong> tarafından <strong> yapılmıştır. </p>
