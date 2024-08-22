import { useMutation, useQueryClient } from '@tanstack/react-query'
import { Favourite } from '../models/models'

import { addFavourite } from '../apis/apiClient'

export default function useAddFavourite() {
  const queryClient = useQueryClient()
  return useMutation({
    mutationFn: async (values: Favourite) => addFavourite(values),
    onSuccess: () => {
      queryClient.invalidateQueries({ queryKey: ['favourite'] })
    },
  })
}
