# Rules

## syntax for build rule dates

### mask
```
mm-dd			// return a mask

// sample
01-01			// return a mask for 1er january
8-15			// return a mask for 15nd August
```

### Identifiers
```
[EASTER]		// return easter date
[ORTHODOX_EASTER]	// return orthodox easter date
```

### Add days
only use with date reference
```
(mm-dd) + 1		// compute a mask and add 1 day
([EASTER]) + 1		// compute easter date and add 1 day
```

### sub expression
You can embedded an expression in parenthese
```
// sample
(01-01) + 1		// return a mask for 1er january and add 1 day
8-15			// return a mask 15nd August
```

### First weekday before
only use with date reference

weekday : MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY

```
(01-01) << WEDNESDAY	// return a mask for 1er january and back first Wednesday
```

### First weekday after
only use with date reference

weekday : MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY

```
(01-01) >> WEDNESDAY	// return a mask for 1er january and back first Wednesday
```
