html {
    height: 100vh;
    font-size: 12px;
}

body {
    height: 100%;
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 50px 20px;
}

#header .lead {
    font-size: 2rem;
}

#food-inp {
    width: 700px!important;
    margin: 50px 0px;
}

.container {
    width: 80%;
    max-width: 2000px!important;
}

.food-card {
    background-size: cover!important;
    border-radius: 5px;
    height: 300px;
    margin-bottom: 20px;
}

.food-card-details {
    display: none;
}

.food-card:hover .food-card-details {
    position: relative;
    background-color: rgba(0,0,0,0.7);
    height: 100%;
    width: 100%;
    display: flex!important;
    flex-direction: !important;
    justify-content: center!important;
    align-items: center!important;
}

.food-card:hover {
    cursor: pointer;
}

#dish-area {
    padding: 0px;
    box-shadow: 2px 10px 20px rgba(0,0,0,0.5);
    margin-top: 100px!important;
}

#recipe-header {
    height: 500px;
    background-size: cover!important;
    display: flex;
    flex-direction: column;
    justify-content: flex-end;
    color: white;
}

#recipe {
    padding: 50px;
}

#recipe .display-2 {
    margin-bottom: 80px!important;
}

.ingredient-list {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    background-color: white;
    color: black;
}

#dish-img {
    height: 300px;
    margin-top: -160px;
    margin-bottom: 50px;
    transition: all 0.2s ease-in;
}

#dish-img:hover {
    transform: scale(1.1);
    cursor: pointer;
}

.ingredient {
    padding: 15px;
    width: 100%;
}

.ingredient:nth-of-type(2n+1) {
    background-color: #f5f5f5;
}

.amount {
    float: right;
}

#steps .lead {
    font-size: 1.4rem;
}

@media (max-width: 1600px)
{
    .ingredient-list {
        margin-bottom: 40px;
    }

    .container {
        width: 100%;
        padding: 0px;
    }
}

@media (max-width : 900px) 
{
    #recipe {
        padding: 50px 0px;
    }

    .display-2 {
        font-size: 4rem;
    }
    .display-1 {
        font-size: 4.3rem;
    }

    .col-xl-3 {
        padding: 0;
    }
    #recipe .display-2 {
        margin-bottom: 40px!important;
    }

    #recipe-header {
        height: 400px;
    }

    #food-inp {
        width: 300px!important;
    }
}
Footer
