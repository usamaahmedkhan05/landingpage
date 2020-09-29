document.getElementsByClassName('details')[1].style.display='none';
document.getElementsByClassName('details')[2].style.display='none';
document.getElementsByClassName('buttoncol')[0].style.display='none';
document.getElementsByClassName('buttoncol')[2].style.display='none';

var x = document.getElementsByClassName('details')[0];
var y = document.getElementsByClassName('details')[1];
function nextclicked()
{

   if (document.getElementsByClassName('details')[0].style.display !=='none')
    {
        document.getElementsByClassName('details')[0].style.display='none';
        document.getElementsByClassName('details')[1].style.display='initial';
        document.getElementsByClassName('buttoncol')[0].style.display='initial';
        document.getElementById('step').innerHTML = '2';
        document.getElementById('titleheading').innerHTML = 'Business location';
    }
    else if (document.getElementsByClassName('details')[1].style.display !=='none')
        {
            document.getElementsByClassName('details')[1].style.display='none';
            document.getElementsByClassName('details')[2].style.display='initial';
            document.getElementsByClassName('buttoncol')[0].style.display='initial';
            document.getElementsByClassName('buttoncol')[1].style.display='none';
            document.getElementsByClassName('buttoncol')[2].style.display='initial';
            document.getElementById('step').innerHTML = '3';
            document.getElementById('titleheading').innerHTML = 'Your Details';
            
        }
}
function previousclicked()
{
    if (document.getElementsByClassName('details')[2].style.display !=='none')
        {
            document.getElementsByClassName('details')[2].style.display = 'none';
            document.getElementsByClassName('details')[1].style.display = 'initial';
            document.getElementsByClassName('buttoncol')[0].style.display='initial';
            document.getElementsByClassName('buttoncol')[1].style.display='initial';
            document.getElementsByClassName('buttoncol')[2].style.display='none';
            document.getElementById('step').innerHTML = '2'; 
            document.getElementById('titleheading').innerHTML = 'Business Location';
            
            
        }
    else if (document.getElementsByClassName('details')[1].style.display !=='none')
        {
            document.getElementsByClassName('details')[1].style.display = 'none';
            document.getElementsByClassName('details')[0].style.display = 'initial';
            document.getElementsByClassName('buttoncol')[0].style.display='none';
            document.getElementById('step').innerHTML = '1';
            document.getElementById('titleheading').innerHTML = 'Business Details';
        }

}