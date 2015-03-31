Shindy
======

Shindy is joined community effort to create and unify the way local User Groups manage their events. 

This project is licensed under the MIT OSS license. See [license](https://github.com/dotnetmiami/Shindy/blob/dev/license.txt)

[![Build status](https://ci.appveyor.com/api/projects/status/7l1mnynbqj27nbay?svg=true)](https://ci.appveyor.com/project/janierdavila/shindy)



## Contributing

See our [Trello board](https://trello.com/board/shindy-user-group-web-app/515d8d0ceb07c5370f003e67)

**Please note:** We use [Nuget package restore](http://docs.nuget.org/docs/workflows/using-nuget-without-committing-packages)


### Coding guidelines

See our [Coding Guidelines](https://github.com/dotnetmiami/Shindy/blob/master/CodingGuidelines.md)

### Project Workflow

Our workflow is loosely based on [Github Flow](http://scottchacon.com/2011/08/31/github-flow.html). We actively develop in our current fork, even when we have access to the main repository. This means that all pull requests by contributors (and owners) need to come from their respective fork. Most of the time, it will make sense to create your own feature branch in your own fork and create a pull request from it. Creating a pull request allows the community to comment on your work and provide feedback before it gets merged to master.

The master branch always matches the current release.
  

### Submitting Pull requests

Make sure you can build the code. Familiarize yourself with the project workflow and our coding conventions. If you don't know what a pull request is
read this [https://help.github.com/articles/using-pull-requests](https://help.github.com/articles/using-pull-requests).

**Tests**

-  We use [XUnit](http://xunit.codeplex.com/) as testing framework
-  Tests need to be provided for every bug/feature that is completed.
-  Tests only need to be present for issues that need to be verified by QA (e.g. not tasks)
-  If there is a scenario that is far too hard to test there does not need to be a test for it.
- "Too hard" is determined by the team as a whole.

## The Git Workflow

We realize there several ways to work with Git with many flows. This is the one we use to be productive. Local branching is very helpful when isolating your work. Feedback is welcome. 

### When starting a new feature/unit of work.
    
1.  __Pull the latest.__
    Begin by pulling to make sure you are up-to-date before creating a branch to do your work 
    This assumes you have no local commits that haven't yet been pushed (i.e., that you were 
    previously up-to-date with origin).
    
        git pull 
    
2.  __Create a topic branch to do your work.__
    Working in a topic branch isolates your work and makes it easy to bring in updates from
    other developers without cluttering the history with merge commits. You should generally
    be working in topic branches. If you do make changes in the master branch, just run this
    command before commiting them, creating the branch just in time.

        git checkout -b <topic branch>
    
3.  __Do your work.__
    Follow this loop while making small changes and committing often.    

    1.  Make changes.
    2. Test your changes (you're practicing TDD, right?)
    3. Add your changes to git's index.
        
            git add -A

    4. Commit your changes.
        
            git commit -m "<description of work>"
        
    5. if (moreWorkToDo) go to #3.1 else go to #4.

4.  __Integrate changes from other developers.__ 
    Now you're finished with your feature or unit of work, and ready to push your changes, 
    you need to integrate changes that other developers may have pushed chances since you 
    started.

    __PRO TIP: CLOSE VISUAL STUDIO__
    
    There are a few steps to follow to make sure you keep the history clean as you integrate.
    
    1.  __Fetch changes from origin.__
        Use `git fetch` instead of `git pull`, because `git pull` automatically tries to merge the 
        new changes with your local commits, creating an ugly (and useless) merge commit.
        
            git fetch origin
        
    2.  __Rebase your topic branch against origin/master.__
        You want to reolcated your changes on top of any changes that were pulled in the
        in the fetch, above. You need to do this against origin/master instead of 
        master, because master isn't yet up to date (remember, you're still in your
        topic branch).

        You might have rebase conflicts, in which case you'll need to resolve them before
        continuing with `git rebase --continue`. You might want to use `git mergetool` to help.
        
            git rebase origin/master
        
  
5.  __Integrate your changes into the master branch.__
    Now that your topic branch has a clean history, it's easy to use `git rebase` to integrate
    your changes into the master branch with the following three commands. Note that the 
    `git pull` will not create a merge commit, provided you haven't made any changes on master
    (e.g., that you followed the advice of making all changes in your topic branch).
    
        git checkout master
        git pull
        git rebase <topic branch>
    
6.  __Push changes.__
    Now that you're master branch's history is correct and clean, you can push to origin.
    
        git push origin

7.  __Delete the topic branch__
    The topic branch you created in Step #2 is no longer needed so it's best to delete it and 
    start with a new clean branch when you're ready to start your next unit of work.
    
        git branch -d <topic branch>

