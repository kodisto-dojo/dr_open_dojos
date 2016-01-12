# Open Coding Dojos held at the Dominican Republic (DR).

The file structure is as follows: 
```
year
  - event_code
    - free structure here
```

Inside each event participants are free to add their individual or group katas. So if you see something like this:
```
2020
  - Santiago_25
    - GameOfLife
      - TheCrazyOnes
      - peter
      - mary
```

You can assume that:
- This dojo was held at city of Santiago
- Was the number 25 within this city
- The group worked on the GameOfLife kata
- And that three solutions were added to the repo, one by a group called "TheCrazyOnes", one by the user peter, and the last one by the user mary.

## FAQs
### How do I add my solution to some Kata?
Prior each event the root directory will be created, and maybe a sub-directory for each kata. You must fork the this repo, add your solution under the corresponding directory and submit a pull-request.

## Good Practices / Pull requests blockers
- Do not add binaries to your solution (.exe, .dll, .class, ...)
- Add a README.md file to your root solution folder explaining all necesary details about it. If is a group Kata, include a list of people and their github users.
