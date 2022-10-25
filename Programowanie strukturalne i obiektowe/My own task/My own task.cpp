
#include <iostream>
#include <ctime>


class Person
{

private:
	std::string name, surname, sex;
	int weight, YearOfBirth;





public:

	Person()
	{
		name = "Kszyœ";
		surname = "Kerfuœ";
		sex = "Men";
		YearOfBirth = CurrentYear();
		weight = 2137;
	}



	Person(std::string name, std::string surname, std::string sex, int YearOfBirth, int weight)
	{
		this->name = name;
		this->surname = surname;
		this->sex = sex;
		this->YearOfBirth = YearOfBirth;
		this->weight = weight;
		this->Majority();

	}


	void ShowInfo()
	{
		std::cout << "***********************************\n";
		std::cout << "Imie oraz Nazwisko: " << name   <<" " << surname << "\n";
		std::cout << "P³eæ: " << sex << "\n";;
		std::cout << "Data urodzenia " << YearOfBirth << "\n";
		std::cout << "Waga: " << weight << "\n";
		std::cout << "Majority: " << Majority() << "\n";
		std::cout << "***********************************\n";
	}



	int  CurrentYear()
	{
		time_t now = time(0);

		tm* localTimeStructTm = new tm;
		localtime_s(localTimeStructTm, &now);

		return 1900 + localTimeStructTm->tm_year;
		
	}


	std::string Majority()
	{
		
		time_t now = time(0);

		tm* localTimeStructTm = new tm;
		localtime_s(localTimeStructTm, &now);
		if (1900 + localTimeStructTm->tm_year - YearOfBirth >= 18)
			return "Yes\n";
		else
		  return   "No\n";
		

	}




};







int main()
{
	setlocale(LC_CTYPE, "polish");

	Person personFirst;
	personFirst.ShowInfo();
	Person personSecond("Bodgan", "Bogdan", "Women", 1990, 120);
	personSecond.ShowInfo();

	Person personThird("Jorge", "Flhoryda", "Czarny", 1865, 95);
	personThird.ShowInfo();


}



