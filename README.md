Follow the guide below to utilise this repository (repo).

1. Two approaches you can choose to set up Github on your desktop device:
    1. GitHub Desktop software if you'd like to integrate your project without using command prompts https://desktop.github.com/
    2. Git scm (git) for command prompts-based management. https://git-scm.com/. Installing this will give you git-bash to manage your project.


2. When you have set up the git, clone this repository in your computer to push and pull the update easily. 
    Clone for users using GitHub desktop client can follow this https://docs.github.com/en/desktop/adding-and-cloning-repositories/cloning-and-forking-repositories-from-github-desktop
    Clone for users using git scm can follow this tutorial https://github.com/git-guides/git-clone and https://git-scm.com/docs/git-clone


3. Before starting every work each time perform a git pull (for git scm follow https://git-scm.com/docs/git-pull  for GitHub Desktop client fetch origin and pull)

4. When you have set up GitHub repo in your desktop device each team should create a folder to store their project (by creating a folder locally on your selected GitHub repository location in your device, then push the folder to the repo). Follows this format Team(Number)_ProjectName. For example Team10_FlyHigh

5. Your team's entire unity project and other documents should be within the folder that you have created in this repo. You can follow this tutorial  https://www.youtube.com/watch?v=qpXxcvS-g3g (You may want to push this project after you push the gitignore file (see step below)).
6. Copy and paste the git ignore file you can find in the root of this repo to your unity project folder(don't move it, just copy-paste it). Pushing this gitignore before pushing your entire project will avoid possible error

    !!! Important for your unity project-related version control!!!
    1. Your gitignore should be in the root of unity project folder. This will prevent the big files to be uploaded to the repository (there's no storage for that here)
    2. Your assets and builds (i.e., png, obj, fbx, and your build (apk) will not be uploaded to this repo, this is why you have to store your assets properly in the corresponding assets folder and builds folder and upload that in cloud storage (updated for any changes) and provide a way to access this and understand when was the latest changes within your team repo folder. Therefore every person who needs to open or run the project needs to see whether they need to update their assets/builds or not then update their local file accordingly.
    3. These steps should allow for the project to be run locally on every computer (through pulling the project and updating the assets). So make sure to test this within your team.

7. Merge conflicts: Follow a tutorial: https://www.simplilearn.com/tutorials/git-tutorial/merge-conflicts-in-git.

8. Avoid (forgetting to pull before starting, push when you are not clear about the conflicts present and need merging).
9. Do put a message and description of your commit to allow people to understand what was performed.
10. You can create a branch for your work, however, any issue arising from this branch will be solely your responsibility.
   
Don't hesitate to ask for help.
Stuff it up, and move on having learned something (happens to all of us).
