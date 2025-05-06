# 🏎️Rawi Rush 

<div align = center >
  <img src = 'https://github.com/user-attachments/assets/23b13318-91a9-438a-9ab8-8b3df2ef98d7' >
</div>

Rawi Rush, C# ve Windows Forms kullanılarak geliştirdiğim bir araba yarış oyunu. `Bu oyunu 1. sınıftayken tasarladım`, ancak kullandığım bazı görsellerin telif haklarından dolayı yayınlamamıştım. Şimdi görselleri değiştirerek GitHub'da paylaşıyorum.

## 🎮 Oyuna Genel Bakış

**Rawi Rush**, klasik bir trafik kaçış oyunu. Amacınız, diğer araçlarla çarpışmadan mümkün olduğunca uzağa gitmek. Oyun ilerledikçe zorluk artıyor, araçlar daha hızlı hareket ediyor ve daha çok engelle karşılaşıyorsunuz.

### Temel Özellikler
- İki farklı kontrol seçeneği: Klavye veya Fare
- İki tip araba seçimi: Yarış Arabaları veya Klasik Arabalar
- 5 farklı seviye ve her seviyede değişen araba tasarımları
- Skor takip sistemi
- Ses efektleri ve müzik

## 📱 Ana Sayfa

![Ana Sayfa](https://github.com/user-attachments/assets/f115837c-5ab7-4181-b5b9-964d521a5785)

Ana menü oyunun başlangıç noktası. Bu ekranda şu öğeler bulunuyor:

- **Score**: Daha önce oynadığınız oyunlarda elde ettiğiniz en yüksek mesafeyi metre cinsinden gösteriyor
- **ALRAWI logosu**: Benim tüm projelerimde kullandığım marka logosu
- **Start**: Oyunu başlatan buton
- **Exit**: Oyundan çıkış yapmanızı sağlayan buton
- **CONTROL** paneli: Oyunu nasıl kontrol edeceğinizi seçebileceğiniz bölüm
  - Keyboard: WASD tuşları veya ok tuşları ile oynanır
  - Mouse: Fareyi hareket ettirerek araba kontrol edilir
- **CAR TYPE** paneli:
  - RACE CAR: Yarış arabaları ile oynamanızı sağlar
  - CLASSIC CAR: Klasik arabalarla oynamanızı sağlar

### Form1.cs Kodları

Form1, oyunun ana menüsünü yöneten sınıf. Bu sınıf oyunun başlangıç ekranını gösteriyor ve kullanıcı tercihlerini alıyor.

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CarRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
        }
        private void START_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            
            Form2 frm2 = new Form2();
            frm2.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SCORE.Text = Settings1.Default.Score.ToString() + " M";
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
```

Form1 sınıfında başlıca şu işlemler gerçekleşiyor:
- Form yüklendiğinde daha önce kaydedilen en yüksek skoru yüklüyor
- Start butonuna tıklandığında, ana menüyü gizleyip oyun ekranını açıyor
- Exit butonuna tıklandığında veya ESC tuşuna basıldığında uygulamadan çıkış yapıyor

## 🏁 Oyun Ekranı
### Yarışma Arabası
![Oyun Ekranı1](https://github.com/user-attachments/assets/58ddd7b1-d0ce-4f34-99f3-9bc95f854a6a)
### Klasik Arabası
![Oyun Ekranı2](https://github.com/user-attachments/assets/52a5731f-b0b6-4af5-b4e2-901ae23130a6)

Oyun ekranı, esas oyun deneyiminin yaşandığı yer. Bu ekranda şu özellikleri görüyoruz:

- Daha önce elde edilen en yüksek skor (Score)
- Mevcut seviye (Level)
- Şu ana kadar aldığınız yol (Road)
- Aracınızın hızı (Speed)
- Klavye veya fare ile kontrol edilen oyuncu arabası
- Rastgele oluşturulan ve yukarıdan aşağıya doğru hareket eden engel araçlar

Oyun ilerledikçe, seviyeler yükselerek hız artar ve karşınıza çıkan araçların sayısı çoğalır. Ayrıca her seviyede aracınızın modeli değişir.

### Form2.cs Kodları

Form2, oyunun ana motorunu içeren sınıf. Bu sınıf araba hareketlerini, çarpışma kontrollerini, seviye ilerlemesini ve skor hesaplamasını yönetiyor.

```csharp
// Form2.cs'den önemli parçalar

// Seviye sistemi
void Lavel()
{

    //2. lavel
    if (Road1>125&&Road1<350)
    {
        LavelNum.Text = "2";
        if (speed1 < 100)
            speed1++;
        LinesTimer.Interval = 125;
        ChoseTimer.Interval = 100;
        move = 16;
        if (frm1 != null && frm1.RaceType.Checked)
        {
            RedCar.Image = BlueCar2.Image;
        }
        else
        {
            RedCar.Image = BlackCar2.Image;
        }
    }
    //3. lavel
    else if (Road1 > 350 && Road1 < 600)
    {
        LavelNum.Text = "3";
        if (speed1 < 125)
            speed1++;
        LinesTimer.Interval = 100;
        ChoseTimer.Interval = 75;
        move = 18;
        if (frm1 != null && frm1.RaceType.Checked)
        {
            RedCar.Image = WhiteCar3.Image;
        }
        else
        {
            RedCar.Image = BlackCar3.Image;
        }
    }
    // ... (diğer seviyeler)
}

// Araba oluşturma ve kontrol etme
class CarChoos
{
    public bool ObstacleCar = false;
    public PictureBox Cars;
    public bool time = false;
}

void CarsShow(PictureBox pb)
{
    int r = rnd.Next(0,4);
    switch (r)
    {
        case 0:
            pb.Image = Properties.Resources.car0;
            break;
        case 1:
            pb.Image = Properties.Resources.car1;
            break;
        case 2:
            pb.Image = Properties.Resources.car2;
            break;
        case 3:
            pb.Image = Properties.Resources.car3;
            break;
    }
    pb.SizeMode = PictureBoxSizeMode.StretchImage;
}

// Çarpışma kontrolü
if (DifWidth > AbsoluteX && DifHeight > AbsoluteY)
{
    Movement = false;
    axWindowsMediaPlayer1.URL = @"music/crash.mp3";
    axWindowsMediaPlayer1.Ctlcontrols.play();
    LinesTimer.Enabled = false;
    ChoseTimer.Enabled = false;
    if (Road1 > Settings1.Default.Score)
    {
        Settings1.Default.Score = Road1;
        Settings1.Default.Save();
        Score0.Text = Settings1.Default.Score.ToString();
    }
    Form3 frm3 = new Form3();
    frm3.ShowDialog();
    this.Close();
}
```

Form2 sınıfında şu önemli işlemler gerçekleşiyor:
- **CarChoos** yardımcı sınıfı ile rastgele araçların özelliklerini takip ediyor
- **CarsShow** metodu ile rastgele görünümde araçlar üretiyor
- **Lavel** metodu ile oyuncunun ilerleme durumuna göre oyun zorluğunu ve araç modelini ayarlıyor
- Timer'lar yardımıyla yol çizgilerinin hareketini, araçların akışını ve çarpışma kontrollerini gerçekleştiriyor
- Fare veya klavye kontrollerini kullanıcının tercihine göre yönetiyor
- Çarpışma durumunda oyunu sonlandırıp Game Over ekranını açıyor

## 💥 Oyun Sonu Ekranı (Game Over)

![Oyun Sonu Ekranı](https://github.com/user-attachments/assets/b7e1e344-2e6f-4419-8c59-43a4694957fb)

Bir araçla çarpıştığınızda Game Over ekranı açılır. Bu ekranda:

- Mevcut oyunda aldığınız mesafe (Road)
- Tüm zamanların en yüksek skoru (Score)
- İki seçenek bulunur:
  - PLAY: Daha önce seçtiğiniz ayarlarla oyunu yeniden başlatır
  - HOME: Ana menüye döner

Eğer yeni bir rekor kırdıysanız, skor değeri kırmızı arka planla vurgulanır.

### Form3.cs Kodları

Form3, oyun sonu ekranını yöneten sınıf.

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CarRace
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Close();
            frm1.Show();
        }
        
        private void play_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Close();
            frm2.Show();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Form2 frm2 = Application.OpenForms["Form2"] as Form2;
            if (Settings1.Default.Score > Convert.ToInt32(frm2.Road0.Text.Substring(0, frm2.Road0.Text.Length - 1)))
            {
                RoadEd.Text = "Road :" + frm2.Road0.Text;
                ScoreEd.Text = "Score : " + Settings1.Default.Score.ToString() + " m";
            }
            else
            {
                RoadEd.Text = "Road :" + frm2.Road0.Text;
                ScoreEd.Text = "Score : " + Settings1.Default.Score.ToString() + " m";
                ScoreEd.BackgroundImage = RedLine.Image;
                ScoreEd.ForeColor = Color.White;
            }
            
        }
    }
}
```

Form3 sınıfında şu işlemler gerçekleşiyor:
- Formun yüklenmesi sırasında oyuncunun son skorunu ve en yüksek skoru karşılaştırıyor
- Yeni bir rekor kırıldıysa score değerini kırmızı arka planla vurguluyor
- PLAY butonuna tıklandığında yeni bir oyun başlatıyor
- HOME butonuna tıklandığında ana menüye dönüyor

## 🛠️ Teknik Detaylar ve Özellikler

### Seviye Sistemi

Oyun 5 seviyeye sahip ve her seviyede:
- Oyun hızı artar
- Engellerin ortaya çıkma sıklığı artar
- Oyuncu aracının hareket hızı artar
- Oyuncu aracının görünümü değişir

### Kontrol Sistemi

İki farklı kontrol seçeneği sunuluyor:
- **Klavye Kontrolü**: W/A/S/D tuşları ile aracı hareket ettirirsiniz
- **Fare Kontrolü**: Fare imlecinin konumuna göre araç hareket eder

### Skor Sistemi

- Oyunda ilerlediğiniz her metre için skorunuz artar
- Elde ettiğiniz en yüksek skor kalıcı olarak kaydedilir
- Her yeni oyunda bu rekoru kırmaya çalışırsınız

### Çarpışma Sistemi

Araçlar arasındaki çarpışmalar şu formülle hesaplanır:
```csharp
float AbsoluteX = Math.Abs((RedCar.Left + (RedCar.Width / 2)) - (RndCars[i].Cars.Left+(RndCars[i].Cars.Width / 2)));
float AbsoluteY = Math.Abs((RedCar.Top + (RedCar.Height / 2)) - (RndCars[i].Cars.Top + (RndCars[i].Cars.Height / 2)));
float DifWidth = (RedCar.Width / 2) + (RndCars[i].Cars.Width / 2);
float DifHeight = (RedCar.Height / 2) + (RndCars[i].Cars.Height / 2);
```

Bu formül, iki aracın merkez noktaları arasındaki mesafeyi hesaplar ve araçların boyutlarını dikkate alarak çarpışma olup olmadığını belirler.

## 🔧 Kurulum

1. Projeyi indirin veya klonlayın:
```
git clone https://github.com/yourusername/rawi-rush.git
```

2. Visual Studio ile .sln dosyasını açın

3. Projeyi derleyin ve çalıştırın

4. Kullanılan referanslar bunlardır:
    - AxWMPLib
    - Guna.UI2
    - MediaPlayer
    - Microsoft.CSharp
    - Microsoft.VisualBasic
    - stdole
    - System
    - System.Core
    - System.Data
    - System.Data.DataSetExtensions
    - System.Deployment
    - System.Design
    - System.Drawing
    - System.Management
    - System.Net.Http
    - System.Web
    - System.Windows.Forms
    - System.Xml
    - System.Xml.Linq
    - WMPLib

5. Eğer eksik paketler varsa NuGet Paket Yöneticisi ile yükleyin

## 📋 Yapılacaklar

İleriki sürümlerde eklemek istediğim özellikler:

- [ ] Çoklu oyuncu modu
- [ ] Farklı yol ve çevre tasarımları
- [ ] Daha fazla araç tipi
- [ ] Güç kazanımları ve özel yetenekler
- [ ] Zorluk seviyeleri (Kolay, Orta, Zor)

---

© 2025 ALRAWI | Geliştirici: Yasir Alrawi
