![alt text][logo]

[logo]: http://theleadagency.com/Themes/TheLeadAgency/Public/images/logo.png "The Lead Agency Logo"

# Interview Practical Assessment

## Introduction

This is a practical assessment of your ability to code CSS, HTML and
JavaScript to produce a responsive web page. You are not limited to
using vanilla CSS and JavaScript so feel free to use whatever
frameworks/technologies you would normally use or think would help
implement.

### What you will need
1. **Visual Studio** to open the Solution. 
    You can download the [Comunity Edition](https://www.visualstudio.com/downloads/) for free
2. A **SASS compiler** such as [Mindscape Work Bench](https://marketplace.visualstudio.com/items?itemName=MindscapeLimited.MindscapeWebWorkbench) or [Web Compiler ](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebCompiler).

### What is provided
1.  FrontEnd Interview Test solution.
2.  Wireframe for how the page should be structured.
3.  Instructions for how elements in the page should behave.

## The problem

The lead agency is developing their new website and you have been asked
to create the home page.

They wish to use a responsive design so that the website displays nicely
on devices of varying screen size. 

To view the wireframe for the page go to:
-   <http://78vd8c.axshare.com/> (Password is **FETest**)
-   How to use [Axshare Wireframes](Using Axshare Wireframes.md)

The wireframe is interactive and provides a basic example of how the
main navigation and price search should work. Please follow the styles
used in the wireframes where possible. Note that it’s not a design so
roughly positioning items to match the wireframe will be fine.

### How the page should work

#### Header

The navigation in the header should collapse on mobile and tablet views.
The user should be able to toggle it.

#### Price Search

The following steps should take place:

1.  User selects a manufacturer.
2.  Ranges for the selected manufacturer populate the second dropdown list.
3.  User selects a range for the second dropdown list.
4.  User clicks **'Find Price &gt;'**.
5.  A deal for the selected range is displayed if one is available.
6.  User changes manufacturer.
7.  Second dropdown list is reset.
    
Each time the user clicks **'Find Price &gt;'**, the offer previously
retrieved should be replaced.

The back-end of the website has already been developed and it exposes
methods for returning vehicle and offer data that you can use to
populate the drop downs and retrieve offers:

-   **/api/manufacturers**

-   **/api/manufacturers/{manufacturerId}/ranges**
    - e.g. /api/manufacturers/1/ranges

-   **/api/manufacturers/{manufacturerId}/ranges/{rangeId}/offers**
    - e.g. /api/manufacturers/1/ranges/2/offers

#### Latest News

The data for this section will be loaded in with the page. You’ll find a
list of six NewSummary items in the model that you can use to render the
three articles. If you’re unfamiliar with Razor syntax, you’ll find the
image for the articles in the Assets folder which is in the root of the
solution. You will need to use a slider of some sort so that some are
hidden from view but can be viewed by using the arrow buttons that are
on either side.

-   **Desktop – Display 3**
-   **Table – Display 2**
-   **Mobile – Display 1**

## Visual Studio solution

In the solution, you’ll see a folder structure for the site. All of the
files for the front-end are in a folder called Assets. It will be up to
you to decide where to organize your CSS. The structure below is a
starting point but feel free to add any extra files as needed.

-   **/Assets**
    -   **/Styles**
        -   **/Css**
            -   **/Main.css**
        -   **/Sass**
            -   **/Main.scss**
    -   **/Js**
        -   **/Client.js**

As a starting point, there are folder for CSS and SASS, each one
containing a file called Main which you can use for adding your styles.
You’ll need to add the link to the page yourself. If you decide to use
SASS, Visual Studio will take care of its compilation and generate a CSS
file in the same folder for you to reference in the page.

The website already has Bootstrap included, along with JQuery. Also,
there’s a file called Client.js ready for you to write any required
JavaScript.

The view that you’ll be using is in the following location:

-   **/Views/Home/Index.cshtml**