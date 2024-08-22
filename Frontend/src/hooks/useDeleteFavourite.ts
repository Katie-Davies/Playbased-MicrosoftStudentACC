import { useMutation, useQueryClient } from '@tanstack/react-query'
import { deleteFavourite } from '../apis/apiClient'

export function useDeleteFavourite() {
  const client = useQueryClient()
  return useMutation({
    mutationFn: (values: number) => deleteFavourite(values),
    onSuccess: () => {
      client.invalidateQueries({ queryKey: ['favourite'] })
    },
  })
}
