
        // alert popup
    alert('Welcome to Maharashtra State');

    // confirm popup
    confirm('are you sure you want to use this');

    //console log Msg
    console.log("Welcome to our website");

    // console error Msg
    console.error('You need to regisered our website');

    // inner text dynamically
    document.getElementById('lbl').innerText = 'Welcome, User';
    function mouseover() {
            // text underline
            var a1 = document.getElementById('a1');
    a1.style.textDecoration = 'underline';
        }

    // sample code
    function mouseout() {
            // text underline remove
            var a1 = document.getElementById('a1');
    a1.style.textDecoration = 'none';
        }

    // facebook name text over
    function mouseoverf() {
            var f1 = document.getElementById('f1');
    f1.style.textDecoration = 'underline';
        }

    // facebook name text underline out
    function mouseoutf() {
        f1 = document.getElementById('f1');
    f1.style.textDecoration = 'none';
        }

    // label name given dynamically
    document.getElementById('j1').innerText = 'Dairy And Milk Product';
