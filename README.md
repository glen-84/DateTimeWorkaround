# DateTimeWorkaround

```graphql
{
  books(where: {
     publishDate: {
        lt: "2023-10-01"
     }
  }) {
    nodes {
      title
    }
  }
}
```

No results.

```graphql
{
  books(where: {
     publishDate: {
        gt: "2023-10-01"
     }
  }) {
    nodes {
      title
    }
  }
}
```

1 result.
