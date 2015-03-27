int broj;

try{

broj=int.Parse(txtVozilo.Text);

}


catch(FormatExeption){
MessageBox.Show("Pogresan format mora biti broj");
}

catch(Exception greska){

MessageBox.Show("Dogodila se gerska: " + greska);

}
