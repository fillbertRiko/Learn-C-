#include <stdio.h>
#include <iostream>

using namespace std;

//khai bao class PhanSo
class PhanSo
{
private:
	int tu, mau;

public:
	PhanSo(int tu, int mau);
	PhanSo CongPhanSo(PhanSo& conLai);
	void ToiGian();
	PhanSo UCLN(PhanSo& mauConLai);
	void Show();
};

//Chuong trinh chinh
int main()
{
	cout << "Chuong trinh cong 2 phan so \nva dua ra man hinh phan so dang rut gon va chua rut gon\n";
	cout << endl;
	return 0;
}
//Dinh nghia ham
PhanSo::PhanSo(int tu, int mau) {
	this->tu = tu;
	this->mau = mau;
}

PhanSo PhanSo::CongPhanSo(PhanSo& conLai)
{
	int TuSoMoi = (tu * conLai.mau) + (conLai.tu * mau);
	int MauSoMoi = mau * conLai.mau;
	return PhanSo(TuSoMoi, MauSoMoi);
}

void PhanSo::ToiGian()
{

}

void PhanSo::Show()
{
	cout << "Phan so chua rut gon la: " << tu << "/" << mau;
}

PhanSo PhanSo::UCLN(PhanSo& mauConLai)
{
	int a = mau;
	int b = mauConLai.mau;
	while (b != 0)
	{
		int temp = b;
		b = a % b;
		a = temp;
	}
	return PhanSo(1, a); // Return a PhanSo object with the greatest common divisor as the denominator
}