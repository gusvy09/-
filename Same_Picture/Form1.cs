using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Same_Picture
{
    public partial class Form1 : Form
    {
        public event EventHandler Changed;
        int size;
        int idx; // 그림 인덱스
        List<PictureBox> list = new List<PictureBox>(); //픽처박스 리스트 //초기화
        List<int> index = new List<int>(); // 그림의 인덱스 번호 리스트 //초기화
        Random rd; // 랜덤
        int check; // 그림 선택 번호, 선택하면 1씩 증가
        int num;// 중복를 위한 변수(같은 그림이 2개까지만 나오도록 만드는 변수)        
        int compare; // 두 그림 비교 (첫번째 그림의 인덱스번호 저장)
        int check_picture_name; // 첫번째 선택한 그림의 이름.
        int check_back; // 카드를 다 뒤집었는지 비교 -> 카드를 2장씩 맞출때마다 1씩 증가 2x4에선 4가되면 초기화, 4x4에선 8이 되면 초기화
        int score = 0; //점수(아직 구현 안 함)
        int width, height; //가로 세로 (2x4,4x4를 구분하여 생성자에서 초기화 -> width는 4로 고정, height만 2,4 변동)
        public Form1() //생성자
        {
            InitializeComponent();
            Changed += Show_name;
            rd = new Random();
            check_back = 0;
            check = 0;
            game_start();
        }
        public Form1(int mode) //생성자
        {
            InitializeComponent();
            Changed += Show_name;
            rd = new Random();
            check_back = 0;
            check = 0;
            size = mode;
            if (size == 0)
            {
                width = 4; height = 2;
                this.Size = new Size(750, 500);
            }
            else
            {
                width = 4; height = 4;
                this.Size = new Size(750, 800);
            }
            game_start();
        }
        private async void game_start()
        {
            Make_Picture(); // 게임시작
            await Task.Delay(1500); // 카드 외울시간
            Card_back(); // 전체 뒤집기
        }
        private void Card_back() // 카드 전체 뒤집기
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Image = imageList1.Images[8];
            }
        }
        private async void Show_name(object sender, EventArgs e) // 같은 그림 맞추기
        {
            PictureBox pb = new PictureBox();
            pb = sender as PictureBox;
            if (check % 2 == 0)
            {
                check_picture_name = int.Parse(pb.Name);
                pb.Image = imageList1.Images[index[check_picture_name]];
                compare = index[check_picture_name];
                check += 1;
            }
            else
            {
                if (check_picture_name == int.Parse(pb.Name))
                {
                    MessageBox.Show("다른 칸을 클릭해주세요");
                    return;
                }
                else
                {
                    if (compare == index[int.Parse(pb.Name)])
                    {
                        pb.Image = imageList1.Images[index[int.Parse(pb.Name)]];
                        //                        MessageBox.Show("정답");
                        check_back += 1;

                        check += 1;
                        if (check_back % (width * height / 2) == 0)
                        {
                            this.Controls.Clear();
                            list.Clear();
                            index.Clear();
                            game_start();
                        }
                        //남은 카드 비교 -> 재시작만 하면 끝
                    }
                    else
                    {
                        pb.Image = imageList1.Images[index[int.Parse(pb.Name)]];
                        //MessageBox.Show("오답");
                        await Task.Delay(300); // 0.5초 딜레이
                        list[check_picture_name].Image = imageList1.Images[8]; //첫번째 선택카드 뒤집기
                        pb.Image = imageList1.Images[8]; //두번째 선택카드 뒤집기
                        check += 1;
                    }
                }
            }
        }
        private void Make_Picture() // 같은그림 2개씩 만들기 (8칸)
        {
            int i = 0;
            while (i < width * height)
            {
                idx = rd.Next() % (width * height / 2);
                num = index.Where(item => item == idx).Count(); // index중 idx와 같은 item의 개수
                if (num < 2)
                {
                    index.Add(idx);
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(120, 140);
                    pb.Location = new Point(30 + 150 * (i % 4), 80 + 160 * (i / 4));
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Name = i.ToString();
                    pb.Image = imageList1.Images[idx];
                    pb.Click += Changed;
                    list.Add(pb);
                    this.Controls.Add(pb);
                    i++;
                }
            }
        }
    }
}
