@import url('https://fonts.googleapis.com/css2?family=Barlow&family=PT+Sans&display=swap');

:root{
    --dark: #2b2d42;
    --light: #adb5bd;
    --border: #dee2e6;
    --border-btn: #edf2f4;
}

* {
    padding: 0;
    margin: 0;
    box-sizing: border-box;
}

a {
    text-decoration: none;
    font-family: 'PT Sans', sans-serif;
}

.container{
    max-width: 1024px;
    margin: auto;
}

.nav-brand{
    font-size: 1.5em;
    font-weight: bold;
}

.d-flex{
    display: flex;
    flex-wrap: wrap;
}

.justify-between{
    justify-content: space-between;
}

.text-center{
    text-align: center;
}

.border-shadow{
    border: 1px solid var(--border-btn);
    box-shadow: 1px 3px 10px #e9ecef;
}

.text-dark{
    color: var(--dark);
}

.inline{
    display: inline-block;
}

.text-light{
    color: var(--light);
}

.text-gradient{
    background: linear-gradient(to right, #8e2de2, #4a00e0);
    -webkit-background-clip: text;
    background-clip: text;
    -webkit-text-fill-color: transparent;
}

#header nav{
    background-color: #06d6a0;
    padding: 1em 0;
    width: 100%;
}

#site-main{
    margin-top: 6em;
    font-family: 'Barlow', sans-serif;
}

#site-main .container .box-nav > a{
    font-size: 1em;
    padding: .5em 1em;
}

#site-main .container form{
    margin: 2em 0;
}

table{
    border-spacing: 0px;
    width: 100%;
}

.table td, .table th{
    padding: .75em;
    vertical-align: top;
    text-align: center;
    border-top: 1px solid var(--border);
}

.table td > a.btn{
    padding: .3em 1em;
    font-size: 1.1em;
    margin: 0 .2em;
}

.table tr:hover{
    background-color:#06d6a0 ;
}

.table tr:hover td > a{
    box-shadow: none;
}

.table .thead-dark th{
    color: #fff;
    background-color: var(--dark) ;
    border-color: #32383e;
}

@media only screen and (max-width: 1024px){
    table, thead, tbody, th, td, tr{
        display: block;
    }

    thead tr{
        position: absolute;
        top: -9999px;
        left: -9999px;
    }

    tr { border: 1px solid var(--border);}

    td{
        border: none;
        position: relative;
    }

}

/*  add user & update user template */
.form-title{
    margin-top: 2em;
}

.form-title > h2{
    padding: .5em 0;
}

.new_user{
    max-width: 786px;
    margin: auto;
}

#update_user .form-group,
#add_user .form-group{
    margin: .4em 0;
}

#update_user .form-group input[type="text"],
#add_user .form-group input[type="text"]{
    width: 100%;
    padding: .6em 1em;
    margin: .5em 0;
    border: 1px solid var(--border);
    font-family: 'Barlow', sans-serif;
    font-size: 1em;
    border-radius: .2em;
}

#update_user .form-group .radio,
#add_user .form-group .radio{
    margin: 1em 2em;
}

/* adding style to radio buttons */
.radio input[type='radio']{
    position: absolute;
    opacity: 0;
}

.radio input[type='radio'] + .radio-label:before{
    content: "";
    background: var(--border-btn);
    border-radius: 100%;
    border: 1px solid var(--border);
    display: inline-block;
    width: 1em;
    height: 1em;
    position: relative;
    top: -0em;
    margin-right: .5em;
    vertical-align: top;
    cursor: pointer;
    text-align: center;
    -webkit-transition: all 250ms ease;
    transition: all 250ms ease;
}

.radio input[type='radio']:checked + .radio-label:before{
    background-color: #16db93;
    box-shadow: inset 0 0 0 4px #e9ecef;
}

.radio input[type='radio']:focus + .radio-label:before{
    outline: none;
    border-color:#16db93;
}

.radio input[type='radio']:disabled + .radio-label:before{
    box-shadow: inset 0 0 0 4px #e9ecef;
    border-color: #b4b4b4;
    background: #b4b4b4;
}

#update_user .form-group .btn,
#add_user .form-group .btn{
    width: 100%;
    padding: .9em 1em;
    background-color:#16db93; 
    border: none;
    font-family: 'PT Sans', sans-serif;
    font-size: 1em;
    cursor: pointer;
    border-radius: .2em;
    margin: .5em 0;
}

#update_user .form-group .btn:hover,
#add_user .form-group .btn:hover{
    background-color: var(--dark);
    color: var(--border);
}